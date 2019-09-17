# ClickOncePublishExample
update version number from CMD
1-how to use :
    A- use the CMD
    B- go to the directory of ClickOncePublishExample.sln file 
    C-use the cmd to get the targets e.g. : msbuild ClickOncePublishExample.sln /t:GetNextVersion
2-choose the publish directory : 
    A- open ClickOncePublishExample.csproj by text editor like Sublime
    B- edit the Properties of  "DirPublish" Target , and change it to the folder you want to publish to.
3- the Targets:
    1-IncRevisionNumber : increase the revision number of the version
    2-IncBuildNumber    : increase the build number of the version
    3-IncMinorNumber    : increase the minor number of the version
    4-IncMajorNumber    : increase the major number of the version
    5-DirPublish :publish to a choosen folder
    6-GetNextVersion: take the next version number , the result will be like that:  ApplicationVersion : 1.0.0.*
                                                                                    the next version number will be :1.0.0.0
                                                                                    MajorNumber        : 1
                                                                                    MinorNumber        : 0
                                                                                    BuildNumber        : 0
                                                                                    RevisionNumber     : 0
  
