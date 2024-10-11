// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigVersionDifferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The values of the configuration parameters after the values of the configuration parameters are changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;<?xml version="1.0"?>
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
        /// </yandex>&quot;</para>
        /// </summary>
        [NameInMap("NewConfigXML")]
        [Validation(Required=false)]
        public string NewConfigXML { get; set; }

        /// <summary>
        /// <para>The values of the configuration parameters before the values of the configuration parameters are changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;<?xml version="1.0"?>
        /// <yandex>
        ///     <keep_alive_timeout>300</keep_alive_timeout>
        ///     <listen_backlog>4096</listen_backlog>
        ///     <logger>
        ///         <level>debug</level>
        ///         <size>1000M</size>
        ///     </logger>
        ///     <mark_cache_size>5368709120</mark_cache_size>
        ///     <max_concurrent_queries>150</max_concurrent_queries>
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
        /// </yandex>&quot;</para>
        /// </summary>
        [NameInMap("OldConfigXML")]
        [Validation(Required=false)]
        public string OldConfigXML { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
