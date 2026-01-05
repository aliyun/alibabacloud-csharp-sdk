// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CopyProductRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the source product.</para>
        /// <remarks>
        /// <para>The source product can belong to the current account or belong to a product portfolio that is shared by another account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:servicecatalog:cn-hangzhou:146611588617****:product/prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("SourceProductArn")]
        [Validation(Required=false)]
        public string SourceProductArn { get; set; }

        /// <summary>
        /// <para>The name of the destination product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEMO-ECS</para>
        /// </summary>
        [NameInMap("TargetProductName")]
        [Validation(Required=false)]
        public string TargetProductName { get; set; }

    }

}
