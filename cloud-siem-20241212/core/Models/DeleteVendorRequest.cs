// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class DeleteVendorRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the Data Management Center of your threat analysis service is located. Select a region for the Management Center based on the region of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your asset is in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. This parameter is used when an administrator switches to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The vendor ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vd-qlsw5eocx94w9</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

        /// <summary>
        /// <para>The vendor name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("VendorName")]
        [Validation(Required=false)]
        public string VendorName { get; set; }

    }

}
