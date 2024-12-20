// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRtcTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;cleansession&quot;:true,&quot;clientId&quot;:&quot;GID_VOIP@@@ClientId_2000000001271771_100685295007&quot;,&quot;conferenceTopic&quot;:&quot;cs_alicom_voip_conference_pre&quot;,&quot;dataTopic&quot;:&quot;alicom_voip_data_pre&quot;,&quot;host&quot;:&quot;mqtt-cn-4590mdhb901.mqtt.aliyuncs.com&quot;,&quot;meetingEventKeepAliveInterval&quot;:0,&quot;phoneTopic&quot;:&quot;alicom_voip_phone&quot;,&quot;port&quot;:0,&quot;reconnectTimeout&quot;:2000,&quot;registerTime&quot;:0,&quot;sdkClientPort&quot;:8883,&quot;serverId&quot;:&quot;GID_VOIP@@@MTEuMjIuMTQ1Ljgy&quot;,&quot;sgwServerTopic&quot;:&quot;alicom_voip_server_pre&quot;,&quot;tlsport&quot;:443,&quot;tokenData&quot;:&quot;LzMT+XLFl5s/YWJ/MlDz4t/Lq5HC1iGU1P28HAMaxYzmBSHQsWXgdISJ1ZJ+2cxaU0jwYsoyG8Q8cCIbLZTwwaFHf7gc7pPXbJGYgJWUr5ooKsoHaVvvG34cww7W8woWE1OsmZGFDODvooOIjF1CZSorVrR8OwRdprW99yqhMhkJKh7r5f3HfiQgoJWL8b3A85RrRGCSP057skgQ5rIqVAlx7jDFrOTdLtz+krken8qYvpaVBO9wRfFyWQLvxAgNJNx3Oql/hpzc2o3+xbKGTA/P2siLn6Nee1FYk5ClpXcnvfSTM4BAauuWR+oES10VblKEKTU5R/pfjXj3UKOlZ1+OdGO93WA16BR/l1uRb3cOLqya5pjWM+oSmo0sOR7B0ATLz6K1xA0Pc+p6Mu8hZl+OdGO93WA1kj1L0h9Z6CAZG4ol/BNdIg9z6noy7yFmX450Y73dYDWSPUvSH1noIBkbiiX8E10iT0a6ypXxupQdyyrhh8j1yw6otqnw5AT5Tj5VsVWVfflXeZ8nPt1ydXC9nWeHX7K80O6vtOU9M8Qn5VrhkP0F1umbOoYs3NfM+WYZIQx4pkViQo6qqkxgbEg1l6oHJbmOVzrxYRrDTIxqgE/pb0YVJQ==&quot;,&quot;useTLS&quot;:false,&quot;username&quot;:&quot;LTAI27GqAW1VrcQA&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRtcTokenResponseBodyData Data { get; set; }
        public class GetRtcTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>139000000</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200000000*******</para>
            /// </summary>
            [NameInMap("RtcId")]
            [Validation(Required=false)]
            public string RtcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{“cleansession”:true,”clientId”:”GID_VOIP@@@ClientId_****”,”conferenceTopic”:”cs_alicom_voip_conference”,”host”:”mqtt-cn-4590mdhb901.mqtt.aliyuncs.com”,”meetingEventKeepAliveInterval”:0,”phoneTopic”:”alicom_voip_phone”,”port”:0,”reconnectTimeout”:2000,”registerTime”:0,”sdkClientPort”:8883,”serverId”:”GID_VOIP@@@MTEuMTMuMTM2LjExOA==”,”sgwServerTopic”:”alicom_voip_server_pre”,”tlsport”:443,”tokenData”:”abcdef”,”useTLS”:false}</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
