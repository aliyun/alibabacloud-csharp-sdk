// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateApmRequest : TeaModel {
        /// <summary>
        /// apm实例名
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// es实例id
        /// </summary>
        [NameInMap("outputES")]
        [Validation(Required=false)]
        public string OutputES { get; set; }

        /// <summary>
        /// es实例密码
        /// </summary>
        [NameInMap("outputESPassword")]
        [Validation(Required=false)]
        public string OutputESPassword { get; set; }

        /// <summary>
        /// es实例用户名
        /// </summary>
        [NameInMap("outputESUserName")]
        [Validation(Required=false)]
        public string OutputESUserName { get; set; }

        /// <summary>
        /// apm server密码
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
