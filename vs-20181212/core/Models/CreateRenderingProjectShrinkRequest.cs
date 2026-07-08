// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingProjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the project. The description can be 0 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>项目概述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom name of the project. This name is the unique identifier for the project.
        /// The name must meet the following requirements:</para>
        /// <ol>
        /// <item><description><para>Be 1 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Contain only lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// </description></item>
        /// <item><description><para>Start and end with a letter or a digit.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>du_merchant_d</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The session properties.</para>
        /// </summary>
        [NameInMap("SessionAttribs")]
        [Validation(Required=false)]
        public string SessionAttribsShrink { get; set; }

    }

}
