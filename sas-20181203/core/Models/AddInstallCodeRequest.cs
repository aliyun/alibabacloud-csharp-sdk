// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddInstallCodeRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the installation command. The value is a 13-digit timestamp.</para>
        /// <remarks>
        /// <para> The installation command is valid only within the validity period. An expired installation command cannot be used to install the Security Center agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1680257463853</para>
        /// </summary>
        [NameInMap("ExpiredDate")]
        [Validation(Required=false)]
        public long? ExpiredDate { get; set; }

        /// <summary>
        /// <para>The ID of the asset group to which you want to add the asset.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of asset groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8076980</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an image. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: does not create an image.</description></item>
        /// <item><description><b>true</b>: creates an image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyImage")]
        [Validation(Required=false)]
        public bool? OnlyImage { get; set; }

        /// <summary>
        /// <para>The operating system of the asset. Default value: <b>linux</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>linux</b></description></item>
        /// <item><description><b>windows</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The ID of the PrivateLink endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72845</para>
        /// </summary>
        [NameInMap("PrivateLinkId")]
        [Validation(Required=false)]
        public long? PrivateLinkId { get; set; }

        /// <summary>
        /// <para>The name of the proxy cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy_test</para>
        /// </summary>
        [NameInMap("ProxyCluster")]
        [Validation(Required=false)]
        public string ProxyCluster { get; set; }

        /// <summary>
        /// <para>The name of the service provider for the asset. Default value: <b>ALIYUN</b>.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeVendorList~~">DescribeVendorList</a> operation to query the names of service providers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("VendorName")]
        [Validation(Required=false)]
        public string VendorName { get; set; }

    }

}
