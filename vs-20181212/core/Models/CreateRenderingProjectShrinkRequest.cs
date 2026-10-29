// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingProjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the project. The description must be 0 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project overview</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom project name, which serves as the unique identifier for the project.
        /// Naming conventions:</para>
        /// <ol>
        /// <item><description>The length must be 1 to 128 characters.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The first and last characters must be letters or digits.</description></item>
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
        /// <para>The session attributes.</para>
        /// </summary>
        [NameInMap("SessionAttribs")]
        [Validation(Required=false)]
        public string SessionAttribsShrink { get; set; }

    }

}
