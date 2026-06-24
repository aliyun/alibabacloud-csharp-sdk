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
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values are <b>zh</b> for Chinese and <b>en</b> for English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The unique IDs of the anomalous activity subtypes. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>To enable SDDP to detect anomalous activities for subtypes, provide the unique IDs of the anomalous activity subtypes. Call the <b>DescribeEventTypes</b> operation to obtain the IDs.</para>
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
