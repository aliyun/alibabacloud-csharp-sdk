// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of container specifications.</para>
        /// </summary>
        [NameInMap("AICSpecs")]
        [Validation(Required=false)]
        public string AICSpecsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the query results include container information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Included.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Not included.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DescribeAICInstances")]
        [Validation(Required=false)]
        public bool? DescribeAICInstances { get; set; }

        /// <summary>
        /// <para>The list of ENS edge zone IDs.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIdsShrink { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-03</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The server name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Server-Name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The sorting method for query results. You can sort results by one or more of the following fields: ServerIdSort (server ID), ServerNameSort (server name), ExpireTimeSort (expiration time), CreationTimeSort (creation time), and EnsRegionIdSort (edge zone ID).</para>
        /// <para>Valid values: asc (ascending order) and desc (descending order).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ServerIdSort&quot;:&quot;desc&quot;,&quot;ServerNameSort&quot;:&quot;desc&quot;,&quot;ExpireTimeSort&quot;:&quot;asc&quot;}</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number of the query list. Minimum value: <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>100</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of server instance IDs.</para>
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of server specifications.</para>
        /// </summary>
        [NameInMap("ServerSpecs")]
        [Validation(Required=false)]
        public string ServerSpecsShrink { get; set; }

        /// <summary>
        /// <para>The list of operation states.</para>
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public string StatesShrink { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
