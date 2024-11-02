// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentAssetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the assets.</para>
        /// </summary>
        [NameInMap("ComponentAssets")]
        [Validation(Required=false)]
        public List<DescribeComponentAssetsResponseBodyComponentAssets> ComponentAssets { get; set; }
        public class DescribeComponentAssetsResponseBodyComponentAssets : TeaModel {
            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ff6fe161-93e2-464c-a326-fxxxxxx</para>
            /// </summary>
            [NameInMap("AssetUuid")]
            [Validation(Required=false)]
            public string AssetUuid { get; set; }

            /// <summary>
            /// <para>The name of the component to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pyhton3</para>
            /// </summary>
            [NameInMap("Componentname")]
            [Validation(Required=false)]
            public string Componentname { get; set; }

            /// <summary>
            /// <para>The time when the asset was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-23T14:38Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the asset was modified. The time is in the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-23T14:38Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7xx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test asset</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configurations of the asset in the JSON string format. DescribeComponentAssetForm</para>
            /// <remarks>
            /// <para> For more information, see <a href="~~DescribeComponentAssetForm~~">DescribeComponentAssetForm</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;name&quot;: &quot;authMethod&quot;,
            ///         &quot;value&quot;: &quot;ak&quot;
            ///     },
            ///     {
            ///         &quot;name&quot;: &quot;accessKeyId&quot;,
            ///         &quot;value&quot;: &quot;xxxxxxx&quot;
            ///     },
            ///     {
            ///         &quot;name&quot;: &quot;accessKeySecret&quot;,
            ///         &quot;value&quot;: &quot;xxxxx&quot;
            ///     },
            ///     {
            ///         &quot;name&quot;: &quot;roleArn&quot;,
            ///         &quot;value&quot;: &quot;&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFEFB76D-DD0E-5529-BD57-0DAC10B9B30F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
