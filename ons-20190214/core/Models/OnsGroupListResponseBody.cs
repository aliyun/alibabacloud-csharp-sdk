// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupListResponseBodyData Data { get; set; }
        public class OnsGroupListResponseBodyData : TeaModel {
            [NameInMap("SubscribeInfoDo")]
            [Validation(Required=false)]
            public List<OnsGroupListResponseBodyDataSubscribeInfoDo> SubscribeInfoDo { get; set; }
            public class OnsGroupListResponseBodyDataSubscribeInfoDo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsGroupListResponseBodyDataSubscribeInfoDoTags Tags { get; set; }
                public class OnsGroupListResponseBodyDataSubscribeInfoDoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag> Tag { get; set; }
                    public class OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16996623-AC4A-43AF-9248-FD9D2D75****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
