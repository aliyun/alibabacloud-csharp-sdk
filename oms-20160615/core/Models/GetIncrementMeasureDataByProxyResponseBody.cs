// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oms20160615.Models
{
    public class GetIncrementMeasureDataByProxyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compressed")]
        [Validation(Required=false)]
        public string Compressed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;[{\&quot;meteringData\&quot;:{\&quot;ProviderId\&quot;:\&quot;26842\&quot;,\&quot;InstanceId\&quot;:\&quot;XXX\&quot;,\&quot;Size\&quot;:\&quot;123\&quot;,\&quot;UserId\&quot;:\&quot;123\&quot;,\&quot;ProductId\&quot;:\&quot;XX\&quot;},\&quot;modifyTime\&quot;:1700634920,\&quot;status\&quot;:\&quot;Stop\&quot;}]&quot;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hour</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXDEMO</para>
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>645B25AB-4E09-5DCA-8443-A7A58138690B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
