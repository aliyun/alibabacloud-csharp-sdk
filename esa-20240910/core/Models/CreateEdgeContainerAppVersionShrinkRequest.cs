// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: 1) Your account must have an ESA plan with the Edge Container feature enabled. 2) Call CreateEdgeContainerApp first to create an application and obtain the AppId. 3) Complete call chain example: CreateEdgeContainerApp → ListEdgeContainerApps → CreateEdgeContainerAppVersion.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The container group to be deployed for this version, including specific image information. The image information consists of the image address, startup command, parameters, environment variables, and probe rules. Multiple images are supported in a JSON array structure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;Name&quot;: &quot;container1&quot;,
        ///             &quot;Image&quot;: &quot;image1&quot;,
        ///             &quot;Spec&quot;: &quot;1C2G&quot;,
        ///             &quot;Command&quot;: &quot;/bin/sh&quot;,
        ///             &quot;Args&quot;: &quot;-c hello&quot;,
        ///             &quot;ProbeType&quot;: &quot;tcpSocket&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Port\&quot;:8080}&quot;
        ///       },
        ///       {
        ///             &quot;Name&quot;: &quot;container2&quot;,
        ///             &quot;Image&quot;: &quot;image2&quot;,
        ///             &quot;Spec&quot;: &quot;2C4G&quot;,
        ///             &quot;ProbeType&quot;: &quot;httpGet&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Path\&quot;:\&quot;/\&quot;,\&quot;Port\&quot;:80,\&quot;InitialDelaySeconds\&quot;:10}&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public string ContainersShrink { get; set; }

        /// <summary>
        /// <para>The version name. The name must be <b>6 to 128</b> characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verson1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
