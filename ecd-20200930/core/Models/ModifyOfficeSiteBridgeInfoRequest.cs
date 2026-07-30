// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteBridgeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The virtual bridge ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vb-fsifhaiushfishf***</para>
        /// </summary>
        [NameInMap("BridgeId")]
        [Validation(Required=false)]
        public string BridgeId { get; set; }

        /// <summary>
        /// <para>The virtual bridge specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vb.pro</para>
        /// </summary>
        [NameInMap("BridgeLevel")]
        [Validation(Required=false)]
        public string BridgeLevel { get; set; }

        /// <summary>
        /// <para>The third-party plugin type of the virtual bridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unsr</para>
        /// </summary>
        [NameInMap("BridgeType")]
        [Validation(Required=false)]
        public string BridgeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the bridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBridge")]
        [Validation(Required=false)]
        public bool? EnableBridge { get; set; }

        /// <summary>
        /// <para>The activation code object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab5b76f4c0bf4a5abd06ea23991a47afa1a4bb4acb4e4204882b40795f946e74</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-387822****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
