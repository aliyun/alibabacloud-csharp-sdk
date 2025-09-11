// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The container specifications.</para>
        /// </summary>
        [NameInMap("AICSpecs")]
        [Validation(Required=false)]
        public List<string> AICSpecs { get; set; }

        /// <summary>
        /// <para>Spcifies whether the result contains the container information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DescribeAICInstances")]
        [Validation(Required=false)]
        public bool? DescribeAICInstances { get; set; }

        /// <summary>
        /// <para>The IDs of the Edge Node Service (ENS) nodes.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-03</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The name of the server.</para>
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
        /// <para>The sorting order of the results to return. Valid values: ServerIdSort, ServerNameSort, ExpireTimeSort, CreationTimeSort, and EnsRegionIdSort.</para>
        /// <para>asc: ascending order. desc: descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ServerIdSort&quot;:&quot;desc&quot;,&quot;ServerNameSort&quot;:&quot;desc&quot;,&quot;ExpireTimeSort&quot;:&quot;asc&quot;,&quot;CreationTimeSort&quot;:&quot;asc&quot;,&quot;EnsRegionIdSort&quot;:&quot;asc&quot;}</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>100</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the ARM servers.</para>
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// <para>The server specifications.</para>
        /// </summary>
        [NameInMap("ServerSpecs")]
        [Validation(Required=false)]
        public List<string> ServerSpecs { get; set; }

        /// <summary>
        /// <para>The operation statuses.</para>
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public List<string> States { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeARMServerInstancesRequestTags> Tags { get; set; }
        public class DescribeARMServerInstancesRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
