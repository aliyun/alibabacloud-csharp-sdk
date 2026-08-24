// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetCreateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description. The description can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the associated IP pool. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        [NameInMap("IsPublicChannelBackoff")]
        [Validation(Required=false)]
        public bool? IsPublicChannelBackoff { get; set; }

        /// <summary>
        /// <para>The configuration name. This parameter is required. The name can be up to 50 characters in length and must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ValidationOption")]
        [Validation(Required=false)]
        public string ValidationOptionShrink { get; set; }

    }

}
