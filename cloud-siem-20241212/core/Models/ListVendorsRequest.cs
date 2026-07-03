// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListVendorsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If this is your first query or if no next page exists, you do not need to specify this parameter. If a next page exists, set the value to the NextToken value that is returned in the last response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is located. Select a region for the Management Hub based on the region where your asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your asset is outside China.</para>
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
        /// <para>The user ID of a member. An administrator can use this ID to switch to the member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>A list of vendors.</para>
        /// </summary>
        [NameInMap("VendorIds")]
        [Validation(Required=false)]
        public List<string> VendorIds { get; set; }

        /// <summary>
        /// <para>The vendor name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("VendorName")]
        [Validation(Required=false)]
        public string VendorName { get; set; }

        /// <summary>
        /// <para>The vendor type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>preset</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preset</para>
        /// </summary>
        [NameInMap("VendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
