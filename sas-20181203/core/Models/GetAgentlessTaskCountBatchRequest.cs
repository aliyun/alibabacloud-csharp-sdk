// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountBatchRequest : TeaModel {
        /// <summary>
        /// <para>The detection object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: host snapshot</description></item>
        /// <item><description><b>2</b>: host image</description></item>
        /// <item><description><b>3</b>: user snapshot</description></item>
        /// <item><description><b>4</b>: user image</description></item>
        /// <item><description><b>5</b>: NAS file system</description></item>
        /// <item><description><b>6</b>: parallel sandbox</description></item>
        /// <item><description><b>7</b>: security fix</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// <para>The list of resource UUIDs to query. The list can contain 1 to 100 elements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
