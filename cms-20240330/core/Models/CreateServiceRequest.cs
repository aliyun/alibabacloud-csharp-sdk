// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateServiceRequest : TeaModel {
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
        /// <para>Service description, only valid when <c>serviceType=RUM</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mag测试应用</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name, only valid when <c>serviceType=RUM</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mag测试应用</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Application ID, generally not required to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bx3udsi5ie@ed2ba6beebdb6de</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-xxekxxzuad5zzzz</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Service name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mag_test</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>Service status, not required for service creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// <para>Service type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateServiceRequestTags> Tags { get; set; }
        public class CreateServiceRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
