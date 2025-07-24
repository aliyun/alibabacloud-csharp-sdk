// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentInstancesResponseBody : TeaModel {
        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ListComponentInstancesResponseBodyComponentInstances> ComponentInstances { get; set; }
        public class ListComponentInstancesResponseBodyComponentInstances : TeaModel {
            /// <summary>
            /// <para>应用名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>组件服务状态，取值如下：</para>
            /// <list type="bullet">
            /// <item><description>active：主服务</description></item>
            /// <item><description>standby：备用服务。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("BizState")]
            [Validation(Required=false)]
            public string BizState { get; set; }

            /// <summary>
            /// <para>Commission状态，取值如下：</para>
            /// <list type="bullet">
            /// <item><description>COMMISSIONED：已上线</description></item>
            /// <item><description>COMMISSIONING：上线中</description></item>
            /// <item><description>DECOMMISSIONED：已下线</description></item>
            /// <item><description>DECOMMISSIONINPROGRESS：下线进程中</description></item>
            /// <item><description>DECOMMISSIONFAILED：下线失败</description></item>
            /// <item><description>INSERVICE：服务中</description></item>
            /// <item><description>UNKNOWN：未知状态。<para></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSERVICE</para>
            /// </summary>
            [NameInMap("CommissionState")]
            [Validation(Required=false)]
            public string CommissionState { get; set; }

            /// <summary>
            /// <para>组件实例操作状态，取值如下：</para>
            /// <list type="bullet">
            /// <item><description>WAITING：等待中</description></item>
            /// <item><description>INSTALLING：安装中</description></item>
            /// <item><description>INSTALLED：已安装</description></item>
            /// <item><description>INSTALL_FAILED：安装失败</description></item>
            /// <item><description>STARTING：启动中</description></item>
            /// <item><description>STARTED：已启动</description></item>
            /// <item><description>START_FAILED：启动失败</description></item>
            /// <item><description>STOPPING：停止中</description></item>
            /// <item><description>STOPPED：已停止</description></item>
            /// <item><description>STOP_FAILED：停止失败</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("ComponentInstanceState")]
            [Validation(Required=false)]
            public string ComponentInstanceState { get; set; }

            /// <summary>
            /// <para>组件名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOX</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>安装时间戳。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1628248947000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>期望状态，取值如下：</para>
            /// <list type="bullet">
            /// <item><description>WAITING：等待中</description></item>
            /// <item><description>INSTALLING：安装中</description></item>
            /// <item><description>INSTALLED：已安装</description></item>
            /// <item><description>INSTALL_FAILED：安装失败</description></item>
            /// <item><description>STARTING：启动中</description></item>
            /// <item><description>STARTED：已启动</description></item>
            /// <item><description>START_FAILED：启动失败</description></item>
            /// <item><description>STOPPING：停止中</description></item>
            /// <item><description>STOPPED：已停止</description></item>
            /// <item><description>STOP_FAILED：停止失败。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("DesiredState")]
            [Validation(Required=false)]
            public string DesiredState { get; set; }

            /// <summary>
            /// <para>节点ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp17yy050pxo01m2****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>节点名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-worker-1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>本次请求所返回的最大记录条数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>返回读取到的数据位置，空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>7345241A-014C-17D2-A3AC-C72771188F46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>本次请求条件下的数据总量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
