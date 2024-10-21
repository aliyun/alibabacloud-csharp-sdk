// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryArtExtensionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-10-01</para>
        /// </summary>
        [NameInMap("DateOrPeriod")]
        [Validation(Required=false)]
        public string DateOrPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20 cm</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iconicity</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public string Features { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>realism</para>
        /// </summary>
        [NameInMap("InscriptionsAndMarkings")]
        [Validation(Required=false)]
        public string InscriptionsAndMarkings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhang san</para>
        /// </summary>
        [NameInMap("Maker")]
        [Validation(Required=false)]
        public string Maker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>silk</para>
        /// </summary>
        [NameInMap("MaterialsAndTechniques")]
        [Validation(Required=false)]
        public string MaterialsAndTechniques { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The embroidery</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>drawings</para>
        /// </summary>
        [NameInMap("Reference")]
        [Validation(Required=false)]
        public string Reference { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>814B2AF0-ED6F-4C13-B41C-8AC0B1023583</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>peace</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Peace and friendship</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
