// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceInServiceListResponseBodyData Data { get; set; }
        public class OnsInstanceInServiceListResponseBodyData : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<OnsInstanceInServiceListResponseBodyDataInstanceVO> InstanceVO { get; set; }
            public class OnsInstanceInServiceListResponseBodyDataInstanceVO : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public int? InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsInstanceInServiceListResponseBodyDataInstanceVOTags Tags { get; set; }
                public class OnsInstanceInServiceListResponseBodyDataInstanceVOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag> Tag { get; set; }
                    public class OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TopicCount")]
                [Validation(Required=false)]
                public int? TopicCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0598E46F-DB06-40E2-AD7B-C45923EE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
