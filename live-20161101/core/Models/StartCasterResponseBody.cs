// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartCasterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PvwSceneInfos")]
        [Validation(Required=false)]
        public StartCasterResponseBodyPvwSceneInfos PvwSceneInfos { get; set; }
        public class StartCasterResponseBodyPvwSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=false)]
            public List<StartCasterResponseBodyPvwSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponseBodyPvwSceneInfosSceneInfo : TeaModel {
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
            }
        };

        [NameInMap("PgmSceneInfos")]
        [Validation(Required=false)]
        public StartCasterResponseBodyPgmSceneInfos PgmSceneInfos { get; set; }
        public class StartCasterResponseBodyPgmSceneInfos : TeaModel {
            [NameInMap("SceneInfo")]
            [Validation(Required=false)]
            public List<StartCasterResponseBodyPgmSceneInfosSceneInfo> SceneInfo { get; set; }
            public class StartCasterResponseBodyPgmSceneInfosSceneInfo : TeaModel {
                public StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfos StreamInfos { get; set; }
                public class StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class StartCasterResponseBodyPgmSceneInfosSceneInfoStreamInfosStreamInfo : TeaModel {
                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                    }

                }
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
            }
        };

    }

}
