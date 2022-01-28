// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class HealthCheck : TeaModel {
        /// <summary>
        /// 是否开启健康检查。  取值：on | off。
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck_ { get; set; }

        /// <summary>
        /// 健康检查的后端服务器的端口。  取值： 1~65535。    说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// 每次健康检查响应的最大超时时间。  取值：1~300（秒）。  默认值：5。
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// 用于健康检查的域名，取值：  $_ip： 后端服务器的私网IP。当指定了IP或该参数未指定时，负载均衡会使用各后端服务器的私网IP当做健康检查使用的域名。是否要支持？ domain：域名长度为1-80字符，只能包含字母、数字、点号（.）和连字符（-）。   说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// 健康检查正常的HTTP状态码，多个状态码用逗号分隔。  默认值为http_2xx。  取值：http_2xx | http_3xx | http_4xx | http_5xx。   说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// 健康检查的时间间隔。  取值： 1~50（秒）。   说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// 健康检查的method
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// 接收来自运行状况检查的响应需要等待的时间。如果后端ECS在指定的时间内没有正确响应，则判定为健康检查失败。在HealthCheck值为on时才会有效。  取值：1~300（秒）。   说明 如果HealthCHeckTimeout的值小于HealthCheckInterval的值，则HealthCHeckTimeout无效，超时时间为HealthCheckInterval的值。
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// 健康检查类型。  取值：tcp（默认值） | http。
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// 用于健康检查的URI。  长度限制为1~80，只能使用字母、数字和”-/.%?#&amp;“这些字符。 URL不能只为”/“，但必须以”/“开头。    说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// 健康检查连续成功多少次后，将后端服务器的健康检查状态由fail判定为success。  取值：2~10。    说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// 健康检查连续失败多少次后，将后端服务器的健康检查状态由success判定为fail。  取值：2~10。   说明 在HealthCheck值为on时才会有效。
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
