// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartCasterResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PvwSceneInfos")]
        [Validation(Required=true)]
        public StartCasterResponsePvwSceneInfos PvwSceneInfos { get; set; }
        public class StartCasterResponsePvwSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=true)]
            public List<StartCasterResponsePvwSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponsePvwSceneInfosSceneInfo : TeaModel {
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
            }
        };

        [NameInMap("PgmSceneInfos")]
        [Validation(Required=true)]
        public StartCasterResponsePgmSceneInfos PgmSceneInfos { get; set; }
        public class StartCasterResponsePgmSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=true)]
            public List<StartCasterResponsePgmSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponsePgmSceneInfosSceneInfo : TeaModel {
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
                public StartCasterResponsePgmSceneInfosSceneInfoStreamInfos StreamInfos { get; set; }
                public class StartCasterResponsePgmSceneInfosSceneInfoStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=true)]
                    public List<StartCasterResponsePgmSceneInfosSceneInfoStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class StartCasterResponsePgmSceneInfosSceneInfoStreamInfosStreamInfo : TeaModel {
                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=true)]
                        public string TranscodeConfig { get; set; }

                        [NameInMap("VideoFormat")]
                        [Validation(Required=true)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=true)]
                        public string OutputStreamUrl { get; set; }

                    }

                }
            }
        };

    }

}
