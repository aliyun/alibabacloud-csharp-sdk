// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListImportableKMSSecretsForHostRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the host.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to get this ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public int? HostId { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to get this ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the secret to search for. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter for the first request. For subsequent requests, use the <c>NextToken</c> value from the previous response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>42bc833a0a0002dae0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For details about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and availability zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
