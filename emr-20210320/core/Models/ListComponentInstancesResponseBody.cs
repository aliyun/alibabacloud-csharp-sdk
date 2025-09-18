// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance component installation information.</para>
        /// </summary>
        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ListComponentInstancesResponseBodyComponentInstances> ComponentInstances { get; set; }
        public class ListComponentInstancesResponseBodyComponentInstances : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The status of the component service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: the primary service.</description></item>
            /// <item><description>standby: the standby service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("BizState")]
            [Validation(Required=false)]
            public string BizState { get; set; }

            /// <summary>
            /// <para>The status of the Commission. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMMISSIONED</description></item>
            /// <item><description>COMMISSIONING</description></item>
            /// <item><description>DECOMMISSIONED</description></item>
            /// <item><description>DECOMMISSIONINPROGRESS</description></item>
            /// <item><description>DECOMMISSIONFAILED</description></item>
            /// <item><description>INSERVICE</description></item>
            /// <item><description>UNKNOWN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSERVICE</para>
            /// </summary>
            [NameInMap("CommissionState")]
            [Validation(Required=false)]
            public string CommissionState { get; set; }

            /// <summary>
            /// <para>The status of the component. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WAITING</description></item>
            /// <item><description>INSTALLING</description></item>
            /// <item><description>INSTALLED</description></item>
            /// <item><description>INSTALL_FAILED</description></item>
            /// <item><description>STARTING</description></item>
            /// <item><description>STARTED</description></item>
            /// <item><description>START_FAILED</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>STOP_FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("ComponentInstanceState")]
            [Validation(Required=false)]
            public string ComponentInstanceState { get; set; }

            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The timestamp of the installation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628248947000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WAITING</description></item>
            /// <item><description>INSTALLING</description></item>
            /// <item><description>INSTALLED</description></item>
            /// <item><description>INSTALL_FAILED</description></item>
            /// <item><description>STARTING</description></item>
            /// <item><description>STARTED</description></item>
            /// <item><description>START_FAILED</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>STOP_FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("DesiredState")]
            [Validation(Required=false)]
            public string DesiredState { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp17yy050pxo01m2****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-worker-1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If you leave this parameter empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7345241A-014C-17D2-A3AC-C72771188F46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
