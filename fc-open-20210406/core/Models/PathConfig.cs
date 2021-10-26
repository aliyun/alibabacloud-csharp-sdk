// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PathConfig : TeaModel {
        /// <summary>
        /// 该路径/方法对应的函数名称
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// 请求方法，不填表示当前路径的所有方法匹配同一函数
        /// </summary>
        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// 请求路径
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// 该路径/方法对应服务的版本/别名
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// 该路径/方法对应的服务名称
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
