// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAdminaddproductRequest : TeaModel {
        [NameInMap("Cat")]
        [Validation(Required=false)]
        public string Cat { get; set; }

        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Fixed")]
        [Validation(Required=false)]
        public bool? Fixed { get; set; }

        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("IconTheme")]
        [Validation(Required=false)]
        public string IconTheme { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public long? LastModified { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OpenBlank")]
        [Validation(Required=false)]
        public bool? OpenBlank { get; set; }

        [NameInMap("Show")]
        [Validation(Required=false)]
        public bool? Show { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public long? Sort { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("MenusRepeatList")]
        [Validation(Required=false)]
        public List<string> MenusRepeatList { get; set; }

    }

}
