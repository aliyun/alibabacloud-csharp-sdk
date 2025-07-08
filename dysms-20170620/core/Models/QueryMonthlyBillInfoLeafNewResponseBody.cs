// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryMonthlyBillInfoLeafNewResponseBody : TeaModel {
        [NameInMap("CouponPayment")]
        [Validation(Required=false)]
        public string CouponPayment { get; set; }

        [NameInMap("IsSeparatedPrice")]
        [Validation(Required=false)]
        public bool? IsSeparatedPrice { get; set; }

        [NameInMap("LayeredBillDOList")]
        [Validation(Required=false)]
        public List<QueryMonthlyBillInfoLeafNewResponseBodyLayeredBillDOList> LayeredBillDOList { get; set; }
        public class QueryMonthlyBillInfoLeafNewResponseBodyLayeredBillDOList : TeaModel {
            [NameInMap("AddCount")]
            [Validation(Required=false)]
            public long? AddCount { get; set; }

            [NameInMap("AddUnit")]
            [Validation(Required=false)]
            public string AddUnit { get; set; }

            [NameInMap("BillAmount")]
            [Validation(Required=false)]
            public string BillAmount { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("PackageBill")]
            [Validation(Required=false)]
            public string PackageBill { get; set; }

            [NameInMap("SinglePrice")]
            [Validation(Required=false)]
            public string SinglePrice { get; set; }

            [NameInMap("SubjectDetailList")]
            [Validation(Required=false)]
            public List<QueryMonthlyBillInfoLeafNewResponseBodyLayeredBillDOListSubjectDetailList> SubjectDetailList { get; set; }
            public class QueryMonthlyBillInfoLeafNewResponseBodyLayeredBillDOListSubjectDetailList : TeaModel {
                [NameInMap("AddCount")]
                [Validation(Required=false)]
                public long? AddCount { get; set; }

                [NameInMap("AddUnit")]
                [Validation(Required=false)]
                public string AddUnit { get; set; }

                [NameInMap("BillAmount")]
                [Validation(Required=false)]
                public string BillAmount { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("PackageBill")]
                [Validation(Required=false)]
                public string PackageBill { get; set; }

                [NameInMap("SinglePrice")]
                [Validation(Required=false)]
                public string SinglePrice { get; set; }

                [NameInMap("SubjectItemId")]
                [Validation(Required=false)]
                public string SubjectItemId { get; set; }

                [NameInMap("SubjectName")]
                [Validation(Required=false)]
                public string SubjectName { get; set; }

            }

            [NameInMap("SubjectItemId")]
            [Validation(Required=false)]
            public string SubjectItemId { get; set; }

            [NameInMap("SubjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

        }

        [NameInMap("PackageAmount")]
        [Validation(Required=false)]
        public string PackageAmount { get; set; }

        [NameInMap("RealPayment")]
        [Validation(Required=false)]
        public string RealPayment { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalPayment")]
        [Validation(Required=false)]
        public string TotalPayment { get; set; }

    }

}
