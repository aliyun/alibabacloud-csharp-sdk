// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterConfigInXMLRequest : TeaModel {
        /// <summary>
        /// <para>The configuration parameters whose settings you want to modify. You can call the <a href="https://help.aliyun.com/document_detail/452210.html">DescribeDBClusterConfigInXML</a> operation to query configuration parameters, and modify the settings of the returned configuration parameters.</para>
        /// <remarks>
        /// <para>You must specify all configuration parameters even when you want to modify the setting of a single parameter. If a configuration parameter is not specified, the original value of this parameter is retained or the modification fails.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0"?>
        /// <yandex>
        ///     <keep_alive_timeout>400</keep_alive_timeout>
        ///     <listen_backlog>4096</listen_backlog>
        ///     <logger>
        ///         <level>debug</level>
        ///         <size>1000M</size>
        ///     </logger>
        ///     <mark_cache_size>5368709120</mark_cache_size>
        ///     <max_concurrent_queries>201</max_concurrent_queries>
        ///     <max_connections>4096</max_connections>
        ///     <max_partition_size_to_drop>0</max_partition_size_to_drop>
        ///     <max_table_size_to_drop>0</max_table_size_to_drop>
        ///     <merge_tree>
        ///         <max_delay_to_insert>256</max_delay_to_insert>
        ///         <max_part_loading_threads>auto</max_part_loading_threads>
        ///         <max_suspicious_broken_parts>100</max_suspicious_broken_parts>
        ///         <zookeeper_session_expiration_check_period>1</zookeeper_session_expiration_check_period>
        ///     </merge_tree>
        ///     <uncompressed_cache_size>1717986918</uncompressed_cache_size>
        /// </yandex>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The cluster ID. You can call the <a href="https://help.aliyun.com/document_detail/170879.html">DescribeDBClusters</a> operation to query information about all the clusters that are deployed in a specified region, including the cluster IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp108z124a8o7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The reason for the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
