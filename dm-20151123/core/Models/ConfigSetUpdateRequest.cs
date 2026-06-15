// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetUpdateRequest : TeaModel {
        /// <summary>
        /// <para>A description for the configuration set, up to 50 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Configuration set ID. Required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Associated IP pool ID. Optional.</para>
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
        /// <para>Configuration set name. Required. Up to 50 characters. The name must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
