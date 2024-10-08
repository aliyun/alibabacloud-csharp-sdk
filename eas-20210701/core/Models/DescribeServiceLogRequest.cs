// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceLogRequest : TeaModel {
        /// <summary>
        /// <para>The name of the container that runs the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02 15:04:05</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the instance that runs the service. For more information about how to query the instance name, see <a href="https://help.aliyun.com/document_detail/412108.html">ListServiceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo-da290ac8-7fckm</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The IP address of the instance whose logs you want to query. For more information about how to query the IP address of an instance, see <a href="https://help.aliyun.com/document_detail/412108.html">ListServiceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The keyword that you use to query the logs of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the logs that are generated before the instance last restarts. This parameter is available only if the instance restarts.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Previous")]
        [Validation(Required=false)]
        public bool? Previous { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time must be in Coordinated Universal Time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02 15:04:05</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
