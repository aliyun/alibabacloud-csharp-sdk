// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetContactFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContactFlowResponseBodyData Data { get; set; }
        public class GetContactFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The contact flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>274601be-a6d5-4429-bcef-32b51d031c6e</para>
            /// </summary>
            [NameInMap("ContactFlowId")]
            [Validation(Required=false)]
            public string ContactFlowId { get; set; }

            /// <summary>
            /// <para>The time when the contact flow draft was created. The format is YYYY-MM-DD HH:mm:ss.S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The IVR content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;activities&quot;:[{&quot;type&quot;:&quot;INCOMING_CALL&quot;,&quot;id&quot;:&quot;e98f0d47&quot;,&quot;name&quot;:&quot;Start&quot;,&quot;properties&quot;:{&quot;position&quot;:{&quot;x&quot;:263,&quot;y&quot;:164}},&quot;events&quot;:[{&quot;event&quot;:&quot;complete&quot;,&quot;next&quot;:&quot;2d3ad2c2&quot;,&quot;edgeId&quot;:&quot;41f7dbd0&quot;}],&quot;nodeIndex&quot;:0},{&quot;type&quot;:&quot;HANGUP&quot;,&quot;id&quot;:&quot;bd4f37e2&quot;,&quot;name&quot;:&quot;Hang up&quot;,&quot;properties&quot;:{&quot;position&quot;:{&quot;x&quot;:765,&quot;y&quot;:185}},&quot;events&quot;:[{&quot;event&quot;:&quot;complete&quot;,&quot;next&quot;:null}],&quot;nodeIndex&quot;:999},{&quot;type&quot;:&quot;PLAY_SAY&quot;,&quot;id&quot;:&quot;2d3ad2c2&quot;,&quot;name&quot;:&quot;Play audio&quot;,&quot;properties&quot;:{&quot;say&quot;:&quot;Hello, welcome to Cloud Call Center.&quot;,&quot;audioResourceId&quot;:&quot;&quot;,&quot;position&quot;:{&quot;x&quot;:485.5,&quot;y&quot;:153.5},&quot;audioType&quot;:&quot;tts&quot;,&quot;audioInterrupt&quot;:false},&quot;events&quot;:[{&quot;event&quot;:&quot;complete&quot;,&quot;next&quot;:&quot;bd4f37e2&quot;,&quot;edgeId&quot;:&quot;e1af4f1f&quot;}],&quot;nodeIndex&quot;:1}],&quot;description&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The draft ID, which is the ID of the editable draft version corresponding to the current contact flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>566399d7-5558-447c-a72f-9be2768b6a82</para>
            /// </summary>
            [NameInMap("DraftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            /// <summary>
            /// <para>The logon name of the agent currently editing this draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor-xxx</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IVR name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Greeting</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether the contact flow is published. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: Published.</description></item>
            /// <item><description>False: Not published.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// <para>The flow type. Valid values:   </para>
            /// <list type="bullet">
            /// <item><description>MAIN_FLOW: main flow  </description></item>
            /// <item><description>SUB_FLOW: sub-flow  </description></item>
            /// <item><description>SURVEY_FLOW: satisfaction survey flow</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MAIN_FLOW</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time of the last modification. The format is YYYY-MM-DD HH:mm:ss.S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2263B273-AC1B-44EB-BA98-87F2322C6780</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
