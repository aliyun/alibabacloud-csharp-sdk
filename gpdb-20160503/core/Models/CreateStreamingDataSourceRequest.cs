// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateStreamingDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateExternalDataSource</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Data source configuration information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;broker_list&quot;:&quot;broker0:9091,broker1:9091&quot;,&quot;topic&quot;:&quot;topic&quot;}</para>
        /// </summary>
        [NameInMap("DataSourceConfig")]
        [Validation(Required=false)]
        public string DataSourceConfig { get; set; }

        /// <summary>
        /// <para>Data source description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-kafka</para>
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// <para>Data source name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-kafka</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>Data source type. Values:</para>
        /// <list type="bullet">
        /// <item><description>kafka</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kafka</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <remarks>
        /// <para>You can view available region IDs through the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Real-time data service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public int? ServiceId { get; set; }

    }

}
