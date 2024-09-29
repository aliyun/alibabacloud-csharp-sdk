// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateRealisticPortraitRequest : TeaModel {
        [NameInMap("ages")]
        [Validation(Required=false)]
        public List<int?> Ages { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cloth")]
        [Validation(Required=false)]
        public int? Cloth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("color")]
        [Validation(Required=false)]
        public int? Color { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("custom")]
        [Validation(Required=false)]
        public string Custom { get; set; }

        [NameInMap("face")]
        [Validation(Required=false)]
        public List<int?> Face { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("figure")]
        [Validation(Required=false)]
        public int? Figure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public int? Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("hairColor")]
        [Validation(Required=false)]
        public int? HairColor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("hairstyle")]
        [Validation(Required=false)]
        public int? Hairstyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("numbers")]
        [Validation(Required=false)]
        public int? Numbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1:1</para>
        /// </summary>
        [NameInMap("ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
