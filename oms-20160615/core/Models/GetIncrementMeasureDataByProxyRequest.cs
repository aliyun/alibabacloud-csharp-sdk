// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oms20160615.Models
{
    public class GetIncrementMeasureDataByProxyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompressEnable")]
        [Validation(Required=false)]
        public bool? CompressEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hour</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXDEMO</para>
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1700634930</para>
        /// </summary>
        [NameInMap("ModifyEndTime")]
        [Validation(Required=false)]
        public long? ModifyEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1700634920</para>
        /// </summary>
        [NameInMap("ModifyStartTime")]
        [Validation(Required=false)]
        public long? ModifyStartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ProviderId\&quot;:\&quot;26842\&quot;,\&quot;InstanceId\&quot;:\&quot;XXX\&quot;,\&quot;UserId\&quot;:123,\&quot;ProductId\&quot;:\&quot;XX\&quot;}</para>
        /// </summary>
        [NameInMap("RowKeyMapStr")]
        [Validation(Required=false)]
        public string RowKeyMapStr { get; set; }

    }

}
