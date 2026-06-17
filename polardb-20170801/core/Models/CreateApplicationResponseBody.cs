// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-********************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>A list of child components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateApplicationResponseBodyComponents> Components { get; set; }
        public class CreateApplicationResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The ID of the child component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pac-********************</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

        }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the generated order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2148126708*****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the resources are sufficient. This parameter is returned only when <c>DryRun</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceAvailable")]
        [Validation(Required=false)]
        public bool? ResourceAvailable { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
