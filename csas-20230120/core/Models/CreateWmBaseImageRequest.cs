// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public CreateWmBaseImageRequestImageControl ImageControl { get; set; }
        public class CreateWmBaseImageRequestImageControl : TeaModel {
            [NameInMap("LogoVisibleControl")]
            [Validation(Required=false)]
            public CreateWmBaseImageRequestImageControlLogoVisibleControl LogoVisibleControl { get; set; }
            public class CreateWmBaseImageRequestImageControlLogoVisibleControl : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                [NameInMap("LogoBase64")]
                [Validation(Required=false)]
                public string LogoBase64 { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            [NameInMap("TextVisibleControl")]
            [Validation(Required=false)]
            public CreateWmBaseImageRequestImageControlTextVisibleControl TextVisibleControl { get; set; }
            public class CreateWmBaseImageRequestImageControlTextVisibleControl : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public long? Angle { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public long? FontSize { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Opacity")]
                [Validation(Required=false)]
                public int? Opacity { get; set; }

                [NameInMap("PosAx")]
                [Validation(Required=false)]
                public float? PosAx { get; set; }

                [NameInMap("PosAy")]
                [Validation(Required=false)]
                public float? PosAy { get; set; }

                [NameInMap("PosX")]
                [Validation(Required=false)]
                public long? PosX { get; set; }

                [NameInMap("PosY")]
                [Validation(Required=false)]
                public long? PosY { get; set; }

                [NameInMap("SpaceX")]
                [Validation(Required=false)]
                public long? SpaceX { get; set; }

                [NameInMap("SpaceY")]
                [Validation(Required=false)]
                public long? SpaceY { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

                [NameInMap("VisibleText")]
                [Validation(Required=false)]
                public string VisibleText { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("Opacity")]
        [Validation(Required=false)]
        public int? Opacity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12*****</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureWebappInvisible</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
