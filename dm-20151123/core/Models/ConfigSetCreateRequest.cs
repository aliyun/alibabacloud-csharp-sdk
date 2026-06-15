// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetCreateRequest : TeaModel {
        /// <summary>
        /// <para>A description of the configuration set (up to 50 characters).</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of an IP pool to associate with the configuration set. This parameter is optional.</para>
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
        /// <para>The name of the configuration set. The name must be unique and can contain up to 50 characters. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
