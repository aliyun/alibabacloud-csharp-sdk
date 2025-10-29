// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class HealthCheckConfiguration : TeaModel {
        /// <summary>
        /// <para>在将容器视为不健康之前，连续失败的健康检查次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// <para>用于健康检查的HTTP GET请求的URL地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ready</para>
        /// </summary>
        [NameInMap("httpGetUrl")]
        [Validation(Required=false)]
        public string HttpGetUrl { get; set; }

        /// <summary>
        /// <para>在容器启动后，首次执行健康检查前的延迟时间（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>执行健康检查的时间间隔（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// <para>在将容器视为健康之前，连续成功的健康检查次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("successThreshold")]
        [Validation(Required=false)]
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// <para>健康检查的超时时间（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
