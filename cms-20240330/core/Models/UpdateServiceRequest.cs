// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// <para>Extended attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;language&quot;:&quot;java&quot;}</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <para>Service description, only valid when serviceType=RUM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name, only valid when serviceType=RUM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-monitor-test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Service status, only valid when serviceType=RUM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
