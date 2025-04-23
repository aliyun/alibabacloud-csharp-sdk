// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyClusterAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The new cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_06_64_20G_alibase_2019071****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The new image type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public image</description></item>
        /// <item><description>self: custom image</description></item>
        /// <item><description>others: shared image</description></item>
        /// <item><description>marketplace: Alibaba Cloud Marketplace image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The new cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the node to which you want to bind the RAM role.</para>
        /// </summary>
        [NameInMap("RamNodeTypes")]
        [Validation(Required=false)]
        public List<string> RamNodeTypes { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The parameters that are used to connect to the Windows AD server.</para>
        /// </summary>
        [NameInMap("WinAdPar")]
        [Validation(Required=false)]
        public ModifyClusterAttributesRequestWinAdPar WinAdPar { get; set; }
        public class ModifyClusterAttributesRequestWinAdPar : TeaModel {
            /// <summary>
            /// <para>The domain name of the Windows AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpcad.com</para>
            /// </summary>
            [NameInMap("AdDc")]
            [Validation(Required=false)]
            public string AdDc { get; set; }

            /// <summary>
            /// <para>The IP address of the Windows AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.2</para>
            /// </summary>
            [NameInMap("AdIp")]
            [Validation(Required=false)]
            public string AdIp { get; set; }

            /// <summary>
            /// <para>The Windows AD server administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>administrator</para>
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public string AdUser { get; set; }

            /// <summary>
            /// <para>The administrator password of the Windows AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxx</para>
            /// </summary>
            [NameInMap("AdUserPasswd")]
            [Validation(Required=false)]
            public string AdUserPasswd { get; set; }

            /// <summary>
            /// <para>The home directory of the Linux server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("FallbackHomeDir")]
            [Validation(Required=false)]
            public string FallbackHomeDir { get; set; }

        }

    }

}
