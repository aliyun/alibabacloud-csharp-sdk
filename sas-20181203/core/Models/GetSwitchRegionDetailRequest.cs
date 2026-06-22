// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSwitchRegionDetailRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The service switchover type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sg_switch</b>: The server connection is migrated from China to Singapore.</description></item>
        /// <item><description><b>sls_meta_version_switch_stage_1</b>: The log analysis delivery field upgrade switchover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg_switch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
