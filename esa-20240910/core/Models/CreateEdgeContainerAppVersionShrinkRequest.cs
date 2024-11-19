// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The container group to be deployed for this version, which contains information about images.\
        /// The image data contains the image address, startup command, parameters, environment variables, and probe rules. You can specify one or more images. The parameter value is a JSON string.</para>
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
        /// <para>The version name, which must be 6 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verson1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The description of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
