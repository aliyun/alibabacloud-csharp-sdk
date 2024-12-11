// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;AllowedValues&quot;: [
        ///         &quot;ecs.n1.tiny&quot;,
        ///         &quot;ecs.r8a.4xlarge&quot;,
        ///         &quot;ecs.n2.xlarge&quot;,
        ///         &quot;ecs.c7.2xlarge&quot;,
        ///         &quot;ecs.c8i.4xlarge&quot;,
        ///         &quot;ecs.g8i.48xlarge&quot;,
        ///         &quot;ecs.c8a.4xlarge&quot;,
        ///         &quot;ecs.i2.4xlarge&quot;,
        ///         &quot;ecs.r8y.2xlarge&quot;
        ///       ],
        ///       &quot;AssociationParameterNames&quot;: [
        ///         &quot;RegionId&quot;,
        ///         &quot;zoneId&quot;
        ///       ],
        ///       &quot;ParameterKey&quot;: &quot;instanceType&quot;
        ///     },
        ///     {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;AllowedValues&quot;: [],
        ///       &quot;AssociationParameterNames&quot;: [
        ///         &quot;RegionId&quot;,
        ///         &quot;zoneId&quot;,
        ///         &quot;InstanceType&quot;
        ///       ],
        ///       &quot;ParameterKey&quot;: &quot;systemDiskCategory&quot;
        ///     }
        ///   ]</para>
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public Dictionary<string, object> ParameterConstraints { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBEC8072-BEC2-478E-8EAE-E723BA79CF19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
