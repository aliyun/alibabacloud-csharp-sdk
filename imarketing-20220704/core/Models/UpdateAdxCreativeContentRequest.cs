// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class UpdateAdxCreativeContentRequest : TeaModel {
        [NameInMap("Ad")]
        [Validation(Required=false)]
        public List<UpdateAdxCreativeContentRequestAd> Ad { get; set; }
        public class UpdateAdxCreativeContentRequestAd : TeaModel {
            [NameInMap("Bundle")]
            [Validation(Required=false)]
            public List<string> Bundle { get; set; }

            [NameInMap("Clicks")]
            [Validation(Required=false)]
            public List<string> Clicks { get; set; }

            [NameInMap("Crid")]
            [Validation(Required=false)]
            public string Crid { get; set; }

            [NameInMap("Enddate")]
            [Validation(Required=false)]
            public string Enddate { get; set; }

            [NameInMap("Imps")]
            [Validation(Required=false)]
            public List<string> Imps { get; set; }

            [NameInMap("Interacttype")]
            [Validation(Required=false)]
            public int? Interacttype { get; set; }

            [NameInMap("MediaIdList")]
            [Validation(Required=false)]
            public List<string> MediaIdList { get; set; }

            [NameInMap("Nativead")]
            [Validation(Required=false)]
            public List<UpdateAdxCreativeContentRequestAdNativead> Nativead { get; set; }
            public class UpdateAdxCreativeContentRequestAdNativead : TeaModel {
                [NameInMap("Attrname")]
                [Validation(Required=false)]
                public string Attrname { get; set; }

                [NameInMap("Attrvalue")]
                [Validation(Required=false)]
                public string Attrvalue { get; set; }

                [NameInMap("H")]
                [Validation(Required=false)]
                public int? H { get; set; }

                [NameInMap("Mime")]
                [Validation(Required=false)]
                public string Mime { get; set; }

                [NameInMap("W")]
                [Validation(Required=false)]
                public int? W { get; set; }

            }

            [NameInMap("Op")]
            [Validation(Required=false)]
            public int? Op { get; set; }

            [NameInMap("Ostype")]
            [Validation(Required=false)]
            public string Ostype { get; set; }

            [NameInMap("Prereview")]
            [Validation(Required=false)]
            public bool? Prereview { get; set; }

            [NameInMap("Seat")]
            [Validation(Required=false)]
            public string Seat { get; set; }

            [NameInMap("Startdate")]
            [Validation(Required=false)]
            public string Startdate { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public int? Template { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("DspId")]
        [Validation(Required=false)]
        public string DspId { get; set; }

    }

}
