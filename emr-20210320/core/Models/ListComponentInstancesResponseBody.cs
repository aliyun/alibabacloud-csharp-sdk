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
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 组件服务状态，取值如下：
            /// - active：主服务
            /// - standby：备用服务。
            /// </summary>
            [NameInMap("BizState")]
            [Validation(Required=false)]
            public string BizState { get; set; }

            /// <summary>
            /// Commission状态，取值如下：
            /// - COMMISSIONED：已上线
            /// - COMMISSIONING：上线中
            /// - DECOMMISSIONED：已下线
            /// - DECOMMISSIONINPROGRESS：下线进程中
            /// - DECOMMISSIONFAILED：下线失败
            /// - INSERVICE：服务中
            /// - UNKNOWN：未知状态。
            /// <p>
            /// </summary>
            [NameInMap("CommissionState")]
            [Validation(Required=false)]
            public string CommissionState { get; set; }

            /// <summary>
            /// 组件实例操作状态，取值如下：
            /// - WAITING：等待中
            /// - INSTALLING：安装中
            /// - INSTALLED：已安装
            /// - INSTALL_FAILED：安装失败
            /// - STARTING：启动中
            /// - STARTED：已启动
            /// - START_FAILED：启动失败
            /// - STOPPING：停止中
            /// - STOPPED：已停止
            /// - STOP_FAILED：停止失败
            /// </summary>
            [NameInMap("ComponentInstanceState")]
            [Validation(Required=false)]
            public string ComponentInstanceState { get; set; }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 安装时间戳。
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 期望状态，取值如下：
            /// - WAITING：等待中
            /// - INSTALLING：安装中
            /// - INSTALLED：已安装
            /// - INSTALL_FAILED：安装失败
            /// - STARTING：启动中
            /// - STARTED：已启动
            /// - START_FAILED：启动失败
            /// - STOPPING：停止中
            /// - STOPPED：已停止
            /// - STOP_FAILED：停止失败。
            /// </summary>
            [NameInMap("DesiredState")]
            [Validation(Required=false)]
            public string DesiredState { get; set; }

            /// <summary>
            /// 节点ID。
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// 节点名称。
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
