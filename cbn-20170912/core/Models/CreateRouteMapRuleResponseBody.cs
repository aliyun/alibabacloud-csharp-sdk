// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateRouteMapRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF44D7B7-6248-5A60-8A4C-A92388605A57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the route map rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmr-3dm13f66wtctcnydup</para>
        /// </summary>
        [NameInMap("RouteMapRuleId")]
        [Validation(Required=false)]
        public string RouteMapRuleId { get; set; }

    }

}
