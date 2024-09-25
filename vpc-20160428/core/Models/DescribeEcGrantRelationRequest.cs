// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>InstanceType</b> to <b>VBR</b>, specify a VBR ID.</description></item>
        /// <item><description>If you set <b>InstanceType</b> to <b>VPC</b>, specify a VPC ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp12mw1f8k3jgygk9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VBR</b>: queries the permissions that are granted to a VBR.</description></item>
        /// <item><description><b>VPC</b>: queries the permissions that are granted from a VPC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is deployed.</para>
        /// <list type="bullet">
        /// <item><description>If <b>InstanceType</b> is set to <b>VBR</b>, this parameter is required.</description></item>
        /// <item><description>If <b>InstanceType</b> is set to <b>VPC</b>, you can ignore this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
