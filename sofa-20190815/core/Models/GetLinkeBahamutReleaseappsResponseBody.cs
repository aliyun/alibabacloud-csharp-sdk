// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutReleaseappsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutReleaseappsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutReleaseappsResponseBodyResult : TeaModel {
            [NameInMap("ReleaseId")]
            [Validation(Required=false)]
            public string ReleaseId { get; set; }

            [NameInMap("ReleaseRepos")]
            [Validation(Required=false)]
            public List<GetLinkeBahamutReleaseappsResponseBodyResultReleaseRepos> ReleaseRepos { get; set; }
            public class GetLinkeBahamutReleaseappsResponseBodyResultReleaseRepos : TeaModel {
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                [NameInMap("ReleaseApps")]
                [Validation(Required=false)]
                public List<GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseApps> ReleaseApps { get; set; }
                public class GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseApps : TeaModel {
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("Release")]
                    [Validation(Required=false)]
                    public bool? Release { get; set; }

                    [NameInMap("RepoName")]
                    [Validation(Required=false)]
                    public string RepoName { get; set; }

                    [NameInMap("AppUnits")]
                    [Validation(Required=false)]
                    public List<GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnits> AppUnits { get; set; }
                    public class GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnits : TeaModel {
                        [NameInMap("CanRemove")]
                        [Validation(Required=false)]
                        public bool? CanRemove { get; set; }

                        [NameInMap("IterationId")]
                        [Validation(Required=false)]
                        public string IterationId { get; set; }

                        [NameInMap("AppUnitCreatedBys")]
                        [Validation(Required=false)]
                        public List<GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnitsAppUnitCreatedBys> AppUnitCreatedBys { get; set; }
                        public class GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnitsAppUnitCreatedBys : TeaModel {
                            [NameInMap("LinkUrl")]
                            [Validation(Required=false)]
                            public string LinkUrl { get; set; }

                            [NameInMap("StageCnName")]
                            [Validation(Required=false)]
                            public string StageCnName { get; set; }

                            [NameInMap("Subject")]
                            [Validation(Required=false)]
                            public string Subject { get; set; }

                            [NameInMap("TypeCnName")]
                            [Validation(Required=false)]
                            public string TypeCnName { get; set; }

                        }

                        [NameInMap("StageStep")]
                        [Validation(Required=false)]
                        public GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnitsStageStep StageStep { get; set; }
                        public class GetLinkeBahamutReleaseappsResponseBodyResultReleaseReposReleaseAppsAppUnitsStageStep : TeaModel {
                            [NameInMap("CurrentIndex")]
                            [Validation(Required=false)]
                            public long? CurrentIndex { get; set; }
                            [NameInMap("DisplayName")]
                            [Validation(Required=false)]
                            public string DisplayName { get; set; }
                            [NameInMap("FabricStageName")]
                            [Validation(Required=false)]
                            public string FabricStageName { get; set; }
                            [NameInMap("FrontCurrentIndex")]
                            [Validation(Required=false)]
                            public long? FrontCurrentIndex { get; set; }
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("Total")]
                            [Validation(Required=false)]
                            public long? Total { get; set; }
                        };

                    }

                }

            }

        }

    }

}
