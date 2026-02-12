// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageTraceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageTraceResponseBodyData Data { get; set; }
        public class OnsMessageTraceResponseBodyData : TeaModel {
            [NameInMap("MessageTrack")]
            [Validation(Required=false)]
            public List<OnsMessageTraceResponseBodyDataMessageTrack> MessageTrack { get; set; }
            public class OnsMessageTraceResponseBodyDataMessageTrack : TeaModel {
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("TrackType")]
                [Validation(Required=false)]
                public string TrackType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAE5BE23-37A1-4354-94D6-E44AE17E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
