// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyEventTypeStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values: <b>zh</b> and <b>en</b>. The value zh indicates Chinese, and the value en indicates English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the anomalous event subtype. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeEventTypes</b> operation to query the ID of anomalous event subtype.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>020008</para>
        /// </summary>
        [NameInMap("SubTypeIds")]
        [Validation(Required=false)]
        public string SubTypeIds { get; set; }

    }

}
