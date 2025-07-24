// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateServiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;language&quot;:&quot;java&quot;}</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bx3udsi5ie@ed2ba6beebdb6de</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mag_test</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
