// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description. Maximum length: 50 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration set ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The associated IP pool ID. This parameter is optional.</para>
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
        /// <para>The configuration name. This parameter is required. Maximum length: 50 characters. The name must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ValidationOption")]
        [Validation(Required=false)]
        public string ValidationOptionShrink { get; set; }

    }

}
