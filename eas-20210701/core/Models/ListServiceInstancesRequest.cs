// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword used to query instances. Instances can be queried based on instance name, instance IP address, IP address of the server where the instance resides, and instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.118.xx.xx</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The IP address of the server where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// <para>The IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo-bdc5xxxx-8l7rk</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a preemptible instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// <para>The sorting order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The instances are sorted in ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The instances are sorted in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resource group to which the instance belongs.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PublicResource</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DedicatedResource</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service role.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataSet</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>dataset service</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>SDProxy</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>Stable-Diffusion proxy service</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>Standard</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>standard service</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>Queue</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>queue service</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Queue</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the query results.</para>
        /// <list type="bullet">
        /// <item><description><para>Set the value to StartTime.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <para>The value specifies that the query results are sorted based on the time when the instances were created</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
