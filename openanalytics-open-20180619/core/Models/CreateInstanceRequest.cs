// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;operable\&quot;:\&quot;false\&quot;,\&quot;max_cu\&quot;:\&quot;8\&quot;,\&quot;instance_name\&quot;:\&quot;api-test-9\&quot;,\&quot;min_cu\&quot;:\&quot;0\&quot;,\&quot;engine\&quot;:\&quot;spark\&quot;,\&quot;region\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;app_name\&quot;:\&quot;xx\&quot;,\&quot;app_version_name\&quot;:\&quot;xx\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("Component")]
        [Validation(Required=false)]
        public string Component { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CU_PRESTO</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
