// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeStreamingDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Data source configuration information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;brokers&quot;:&quot;broker0:9091,broker1:9091&quot;,&quot;topic&quot;:&quot;topic&quot;}</para>
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
        /// <para>Data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-kafka</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>Data source type, values include:</para>
        /// <list type="bullet">
        /// <item><description>kafka</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>kafka</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>Service status message, for example, in case of an exception, it will show the reason for the exception. In normal Running state, this value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>External data service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// <para>Service status:</para>
        /// <list type="bullet">
        /// <item><description><para>Initializing init</para>
        /// </description></item>
        /// <item><description><para>Running running</para>
        /// </description></item>
        /// <item><description><para>Exception exception</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
