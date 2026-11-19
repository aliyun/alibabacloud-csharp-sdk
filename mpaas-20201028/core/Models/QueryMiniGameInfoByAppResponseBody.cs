// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMiniGameInfoByAppResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<QueryMiniGameInfoByAppResponseBodyContent> Content { get; set; }
        public class QueryMiniGameInfoByAppResponseBodyContent : TeaModel {
            [NameInMap("GameEngine")]
            [Validation(Required=false)]
            public string GameEngine { get; set; }

            [NameInMap("GameMaker")]
            [Validation(Required=false)]
            public string GameMaker { get; set; }

            [NameInMap("GameTypeLevel1")]
            [Validation(Required=false)]
            public string GameTypeLevel1 { get; set; }

            [NameInMap("GameTypeLevel2")]
            [Validation(Required=false)]
            public string GameTypeLevel2 { get; set; }

            [NameInMap("GameTypeLevel3")]
            [Validation(Required=false)]
            public string GameTypeLevel3 { get; set; }

            [NameInMap("GameVersionId")]
            [Validation(Required=false)]
            public string GameVersionId { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("MiniProgramCode")]
            [Validation(Required=false)]
            public string MiniProgramCode { get; set; }

            [NameInMap("MiniProgramId")]
            [Validation(Required=false)]
            public long? MiniProgramId { get; set; }

            [NameInMap("MiniProgramName")]
            [Validation(Required=false)]
            public string MiniProgramName { get; set; }

            [NameInMap("Slogan")]
            [Validation(Required=false)]
            public string Slogan { get; set; }

            [NameInMap("UserProfileData")]
            [Validation(Required=false)]
            public QueryMiniGameInfoByAppResponseBodyContentUserProfileData UserProfileData { get; set; }
            public class QueryMiniGameInfoByAppResponseBodyContentUserProfileData : TeaModel {
                [NameInMap("ActiveRegionCodes")]
                [Validation(Required=false)]
                public string ActiveRegionCodes { get; set; }

                [NameInMap("ActiveRegions")]
                [Validation(Required=false)]
                public string ActiveRegions { get; set; }

                [NameInMap("AgeSegment")]
                [Validation(Required=false)]
                public string AgeSegment { get; set; }

                [NameInMap("AndroidActiveModels")]
                [Validation(Required=false)]
                public string AndroidActiveModels { get; set; }

                [NameInMap("AndroidRatio")]
                [Validation(Required=false)]
                public int? AndroidRatio { get; set; }

                [NameInMap("FemaleRatio")]
                [Validation(Required=false)]
                public int? FemaleRatio { get; set; }

                [NameInMap("HarmonyRatio")]
                [Validation(Required=false)]
                public int? HarmonyRatio { get; set; }

                [NameInMap("IosActiveModels")]
                [Validation(Required=false)]
                public string IosActiveModels { get; set; }

                [NameInMap("IosRatio")]
                [Validation(Required=false)]
                public int? IosRatio { get; set; }

                [NameInMap("MaleRatio")]
                [Validation(Required=false)]
                public int? MaleRatio { get; set; }

                [NameInMap("ProfileRemark")]
                [Validation(Required=false)]
                public string ProfileRemark { get; set; }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
