// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForSaveArtExtensionRequest : TeaModel {
        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-01</para>
        /// </summary>
        [NameInMap("DateOrPeriod")]
        [Validation(Required=false)]
        public string DateOrPeriod { get; set; }

        /// <summary>
        /// <para>Dimensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20 cm</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.art</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Artistic features.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iconicity</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public string Features { get; set; }

        /// <summary>
        /// <para>Inscriptions and markings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>realism</para>
        /// </summary>
        [NameInMap("InscriptionsAndMarkings")]
        [Validation(Required=false)]
        public string InscriptionsAndMarkings { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Artist or creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("Maker")]
        [Validation(Required=false)]
        public string Maker { get; set; }

        /// <summary>
        /// <para>Materials and techniques.</para>
        /// 
        /// <b>Example:</b>
        /// <para>silk</para>
        /// </summary>
        [NameInMap("MaterialsAndTechniques")]
        [Validation(Required=false)]
        public string MaterialsAndTechniques { get; set; }

        /// <summary>
        /// <para>Artwork category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The embroidery</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>Reference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drawings</para>
        /// </summary>
        [NameInMap("Reference")]
        [Validation(Required=false)]
        public string Reference { get; set; }

        /// <summary>
        /// <para>Art subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>peace</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Peace and friendship</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
