// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oms20160615.Models
{
    public class DeleteMeasureDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compressed")]
        [Validation(Required=false)]
        public bool? Compressed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;UserId&quot;:&quot;1192922887522200&quot;,&quot;ProductId&quot;:&quot;VM&quot;,&quot;StartTime&quot;:&quot;1556640000&quot;,&quot;EndTime&quot;:&quot;1556726400&quot;,&quot;Region&quot;:&quot;cn-hangzhou&quot;,&quot;InstanceId&quot;:&quot;test1&quot;,&quot;CPU&quot;:&quot;4&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>raw</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>OMS Domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StartTime&gt;1469980800;StartTime&lt;1469984400</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

    }

}
