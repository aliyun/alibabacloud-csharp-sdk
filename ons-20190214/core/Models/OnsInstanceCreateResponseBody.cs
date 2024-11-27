// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceCreateResponseBody : TeaModel {
        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceCreateResponseBodyData Data { get; set; }
        public class OnsInstanceCreateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the instance that you created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_188077086902****_BXSuW61e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The edition of the instance that you created. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Standard Edition instances</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07E3902-B92E-44A6-B6C5-6AA111111****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
