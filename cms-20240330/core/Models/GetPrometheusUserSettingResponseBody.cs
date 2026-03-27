// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPrometheusUserSettingResponseBody : TeaModel {
        [NameInMap("prometheusUserSetting")]
        [Validation(Required=false)]
        public Dictionary<string, string> PrometheusUserSetting { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>058550FA-DDBE-519E-9C6D-93521B9A5E90</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
