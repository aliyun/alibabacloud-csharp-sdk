// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUuidVulNumClassifyStatisticRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query image vulnerability statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The Uuids parameter specifies image IDs.</description></item>
        /// <item><description>false: The Uuids parameter specifies host UUIDs.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ImageVul")]
        [Validation(Required=false)]
        public bool? ImageVul { get; set; }

        /// <summary>
        /// <para>The unique identifier of the asset. If ImageVul is set to false, specify the host UUID. If ImageVul is set to true, specify the image ID. Separate multiple values with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>391abd09184cbd3743d7f5ec125d****,
        /// e6aeb2a5b6004479398b0bcd1160****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
